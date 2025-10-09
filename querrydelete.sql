-- Delete dependent rows first
DELETE FROM StatusHistory
WHERE status_id BETWEEN 1 AND 12;

-- Now delete from Status
DELETE FROM Status
WHERE status_id BETWEEN 1 AND 12;
